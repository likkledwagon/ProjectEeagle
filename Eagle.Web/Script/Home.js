function LoadHome() {
    Get("../api/news", function(data) {

        var newscontainer = $("#newslist");
        
        data.forEach(function (el) {
            createBlueCallout(el.Title, el.By, el.Content, newscontainer);
        });
    });
}
