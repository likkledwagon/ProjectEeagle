function createBlueCallout(title, right, content, container) {

    var elContainer = CreateDiv("blue-callout");
    var byEm = createElement("em", "pull-right");
    var titleEl = createElement("h4");
    var contentEl = CreateDiv("");

    byEm.html(right);
    titleEl.html(title);
    contentEl.html(content);

    byEm.appendTo(elContainer);
    titleEl.appendTo(elContainer);
    contentEl.appendTo(elContainer);

    container.append(elContainer);
}


function CreateDiv(cssClass) {
    return createElement("div", cssClass);
}

function CreateSpan(cssClass) {
    return createElement("span", cssClass);
}

function createElement(element, cssclass) {
    var html = $("<" + element + "/>");
    html.addClass(cssclass);
    return html;
}