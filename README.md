# Introduction 
This is an event coordination application designed to work for both customers and admins. 

As a customer:
You have the option to schedule a consultation, and view all of the pages designated for customers.
Once a consultation has been approved (in this scenario, an approval would happen after an admin
has met with a customer and approved their event) an admin will then create a booking for an event.
Once the booking has been created, a customer must sign up with the email used in the consultation
and then they are able to manage their booking, including paying for the booking.

As an admin: 
You have full capability to manage bookings and consultations. Once a booking or a consultation
has been made, it is automatically loaded into the calendar. From there it is easy to see when, where, and who
has booked. Admin can fully delete bookings, alter how much is left to pay for a booking, create new bookings, 
and also create new consultations on behalf of the customer. The system is designed to wait for that customer to
create an account with that email and once it does their bookings will automatically be tied to their account. 

# Getting Started
To run on your own device, ensure that Visual Studio is installed. 
Also, this application is configured to use an Azure Storage Account for images
and also uses SQL as it's database. You will need to provide your own instances 
of these to make the application run

From the Package Manager Console:
Enter: 
  dotnet restore
Which should verify that all necessary NuGet packages are installed.

Under Infrastructure:
  ApplicationDbContext.cs:
    Seeded users need their own password
  AuthSenderOptions.cs:
    Enter your SendGrid user and key 
  EmailSender.cs:
    Replace "ENTER EMAIL" with your email 

Under ParkwayNorthEvents:
  appsettings.json:
    Enter in your connection string
    Enter stripe secret and publishable keys
    Enter Azure Storage connection string
    
    
    


# Build and Test
TODO: Describe and show how to build your code and run the tests. 

# Contribute
TODO: Explain how other users and developers can contribute to make your code better. 

If you want to learn more about creating good readme files then refer the following [guidelines](https://docs.microsoft.com/en-us/azure/devops/repos/git/create-a-readme?view=azure-devops). You can also seek inspiration from the below readme files:
- [ASP.NET Core](https://github.com/aspnet/Home)
- [Visual Studio Code](https://github.com/Microsoft/vscode)
- [Chakra Core](https://github.com/Microsoft/ChakraCore)
