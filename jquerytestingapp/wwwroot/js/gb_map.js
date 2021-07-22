var gb_map = (function () {
    function ShowDetailsOnHover(obj) {
        obj.hover(
            //ON HOVER
            function () {
                $("#details-box-title").text(obj.attr("data-title"));
                $("#details-box").css("left", (obj.position().left + obj.width() + 20));
                $("#details-box").css("top", (obj.position().top - 20))
                $("#details-box").show();
            },
            //OFF HOVER
            function () {
                $("#details-box").hide();
                $("#details-box-title").text("");
            })
    }
    function InitDetailsBox() {
        var box = $("<div/>", { id: "details-box" });
        var title = $("<h3/>", { id: "details-box-title" }).css({ width: "100%", height: "20px" });
        box.html(title).hide();
        $("#usmap").after(box);
    }
    function PopulateMap(arr) {
        //arr = [{name="test", x=200,y=100},...]
        var map = $("#usmap");
        var maxX = map.width();
        var maxY = map.height();
        var position = map.position(); 
        $.each(arr, function (index, value) {
            console.log(position)
            var x = position.left + value.x;
            var y = position.top + value.y;
            var sl = $("<div/>", {
                class: "service-location",
                "data-title": value.name
            }).css({
                top: y + "px",
                left: x + "px"
            });
            var btn = $("<button/>", {
                class: "service-location-button"
            });
            ShowDetailsOnHover(sl);
            sl.html(btn);
            $("#usabox").append(sl);
        })
    }
    return {
        map: function (arr) {
            PopulateMap(arr);
        },
        init: function () {
            InitDetailsBox();
        }
    };
})();
