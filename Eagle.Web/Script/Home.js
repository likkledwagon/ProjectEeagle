function LoadHome() {
    Get("../api/news", function(data) {

        var newscontainer = $("#newslist");
        
        data.forEach(function (el) {
            var elementPanel = CreateDiv("panel bigTile");

            var itemElement = CreateDiv("row");
            itemElement.appendTo(elementPanel);

            var titleElement = CreateDiv("col-xs-12 col-sm-6 col-md-8");
            titleElement.html(el.Title);
            titleElement.appendTo(itemElement);

            var contentElement = CreateDiv("row");
            contentElement.appendTo(elementPanel);

            var contentColumnElement = CreateDiv("col-xs-12 col-sm-6 col-md-8");
            contentColumnElement.html(el.Content);
            contentColumnElement.appendTo(contentElement);

            var byElement = CreateDiv("col-xs-6 col-md-4");
            byElement.html(el.By);
            byElement.appendTo(itemElement);


            newscontainer.append(elementPanel);
        });
    });
}

function CreateDiv(cssClass) {
    var element = $("<div />");
    element.addClass(cssClass);
    return element;
}