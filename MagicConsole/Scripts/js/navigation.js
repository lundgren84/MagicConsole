const codeUrl = "/Code/Index";

$(document).ready(function () {

    //Fetch main content when go back in history
    window.addEventListener('popstate', function (e) {
        fetchMainContentFromUrl(document.location.pathname);
    });

    //Fetch main content when press main nav link
    $(".jsMainMenuLink").on("click", function (e) {
        e.preventDefault();

        // Git nav class: active and remove others on click

        var url = $(this).attr("href");

        fetchMainContentFromUrl(url);
        window.history.pushState("", "", url);
    });

    function fetchMainContentFromUrl(url) {

        $("#mainContentArea").fadeOut(100);

        $.ajax({
            type: "GET",
            url: url,
            dataType: "html",
            success: function (data) {

                if (url != codeUrl) {
                    setTimeout(function () {
                        $("#mainContentArea").html(data);
                    }, 100);

                    setTimeout(function () {
                        $("#mainContentArea").fadeIn(100);
                    }, 300);
                } else {

                    setTimeout(function () {
                        $("#mainContentArea").html("");
                    }, 50);
                    setTimeout(function () {
                        $("#mainContentArea").fadeIn(50);
                    }, 50);
                    setTimeout(function () {
                        $("#mainContentArea").html(data);
                    }, 100);

                }
            },
        });
    };

});