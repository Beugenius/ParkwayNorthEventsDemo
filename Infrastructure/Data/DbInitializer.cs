using ParkwayNorthEvents.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Models;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Bookings.Any())
            {
                return;
            }
            #region Booking an Event 
            var venue = new Venue()
            {
                VenueName = "Usana Ampitheatre",
                VenuePhoneNumber = "1-800-999-7897"
            };
            context.Venues.Add(venue);
            await context.SaveChangesAsync();

            var supplier = new Supplier()
            {
                SupplierName = "McDonald's",
                SupplierPhoneNumber = "123-456-7800"
            };
            context.Suppliers.Add(supplier);
            await context.SaveChangesAsync();

            var booking = new Booking()
            {
                BookingStatus = "New",
                Type = BookingType.DayOfWeddingCoordination,
                Balance = 650.00M,
                EventTitle = "John and Jane's Wedding",
                ClientId = context.ApplicationUsers.Where(x => x.Email == "JohnDoe@ParkwayNorthEvents.com").First().Id,
                ClientName = context.ApplicationUsers.Where(x => x.Email == "JohnDoe@ParkwayNorthEvents.com").First().FullName,
                DateOfEvent = DateTime.Now,
                Description = "John Doe is marrying Jane Doe at the Usana Ampitheatre and they are having McDonald's supply the food"
                // TODO - make new linked venue / booking entry in the db 
                //VenueId = context.Venues.Where(x => x.VenueName == venue.VenueName.ToString()).First().VenueId.ToString(),
                //VenueStatus = "New"
            };
            context.Bookings.Add(booking);
            await context.SaveChangesAsync();
            // get the booking from the db so it has the correct id 
            booking = await context.Bookings.Where(x => x == booking).Select(x => x).FirstAsync();
            var bookedVenue = new VenuesBooked()
            {
                BookingId = booking.BookingId,
                VenueId = context.Venues.Where(x => x.VenueName == venue.VenueName.ToString()).First().VenueId,
                Status = VenueStatus.Unconfirmed
            };
            context.VenuesBooked.Add(bookedVenue);
            await context.SaveChangesAsync();

            var bookedSupplier = new ServicesBooked()
            {
                BookingId = context.Bookings.First().BookingId.ToString(),
                SupplierId = context.Suppliers.First().SupplierId.ToString(),
                ServiceStatus = "New"
            };

            context.ServicesBooked.Add(bookedSupplier);
            await context.SaveChangesAsync();
            #endregion

            #region Suppliers
            var suppliers = new List<Supplier>()
            {
                new Supplier{SupplierName = "Jim's Winery", SupplierPhoneNumber = "999-999-9999"},
                new Supplier{SupplierName = "Terry's Teriyaki Bowl", SupplierPhoneNumber = "555-555-5555"},
                new Supplier{SupplierName = "Jimmy John's", SupplierPhoneNumber = "444-444-4444"}
            };
            foreach(var s in suppliers)
            {
                context.Add(s);
            }
            await context.SaveChangesAsync();
            #endregion
            #region Venues
            var venues = new List<Venue>()
            {
                new Venue{VenueName = "The Ski Lodge", VenuePhoneNumber = "777-777-777"},
                new Venue{VenueName = "Axe Throwing Palace", VenuePhoneNumber = "666-666-6666"},
                new Venue{VenueName = "The Small Church", VenuePhoneNumber = "111-111-1111"}
            };
            foreach (var v in venues)
            {
                context.Add(v);
            }
            await context.SaveChangesAsync();
            #endregion
        }
    }
}
