
$(document).ready(function () {
    BindPageEvents();
    OpenHome();
});

function Get(uri, resultFunction) {
    $.getJSON(uri)
        .done(function(data) {
            resultFunction(data);
        });
};

function getUsers() {
    Get("api/Users", FillPage);
}

function FillPage(data) {
    $("#PageTitle").html(data.Title);
    $("#usersPanel").html(data.Content);
}

function BindPageEvents() {
    $(document.getElementById("LogOutButton")).click(function() {
        Get("api/Users/Logout");
    });

    $("#HomeButton").click(function() {
        OpenHome();
    });

    $("#CalendarButton").click(function() {
        OpenCalendar();
    });
}

function LoadHtml(page) {
    $("#ContentPanel").load("Pages/".concat(page).concat(".html"));
};

function OpenCalendar() {
    LoadHtml("Calendar");
}

function OpenHome() {
    LoadHtml("Home");
}