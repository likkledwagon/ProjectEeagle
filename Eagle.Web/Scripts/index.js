$(document).ajaxError(function (event, jqxhr, settings, exception) {
    if (jqxhr.status === 401) {
        $("div#UnAuthorized").fadeIn();
    }
});

$(document).ajaxSuccess(function(eevent, jqxhr, settings, exception) {
    $("div#UnAuthorized").fadeOut();
});

$(document).ready(function () {
    $("div#UnAuthorized").hide();
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
    $("#LogOutButton").click(function () {
        $("#ContentPanel").html("");
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