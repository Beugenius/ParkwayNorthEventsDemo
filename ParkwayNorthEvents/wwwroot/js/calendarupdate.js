var eventsArr = [];
loadCalendar();

async function loadAjax() {
    await $.ajax({
        url: '/api/booking/',
        method: 'GET',
        dataType: 'json',
        success: function (data) {
            eventsArr = data;
        }
    });
    return;
}
async function loadCalendar() {
    document.addEventListener('DOMContentLoaded', async function () {
        await loadAjax();
        var calendarEl = document.getElementById('calendar');
        var calendar = new FullCalendar.Calendar(calendarEl, {
            initialView: 'dayGridMonth',
            headerToolbar: {
                left: 'prev,next,today',
                center: 'title',
                right: 'agendaWeek,agendaDay',
            },
            events: eventsArr
        });
        calendar.render();
    });
}