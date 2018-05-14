$(document).ready(function () {
    // Add smooth scrolling to all links in navbar + footer link
    $(".navbar a, footer a[href='#top']").on('click', function (event) {
        // Make sure this.hash has a value before overriding default behavior
        if (this.hash !== "") {
            // Prevent default anchor click behavior
            event.preventDefault();

            // Store hash
            var hash = this.hash;

            // Using jQuery's animate() method to add smooth page scroll
            // The optional number (900) specifies the number of milliseconds it takes to scroll to the specified area
            $('html, body').animate({
                scrollTop: $(hash).offset().top
            }, 900, function () {

                // Add hash (#) to URL when done scrolling (default click behavior)
                window.location.hash = hash;
            });
        } // End if
    });

    $(window).scroll(function () {
        $(".slideanim").each(function () {
            var pos = $(this).offset().top;

            var winTop = $(window).scrollTop();
            if (pos < winTop + 600) {
                $(this).addClass("slide");
            }
        });
    });
})


function DisplayProject(projectType, projectIndex) {
    var display = document.getElementById('projectDisplay');
    display.innerHTML = "<div id='myCarousel' class='carousel slide col-sm-6' data-ride='carousel'><!--Indicators--><ol id='projCarouselInds' class='carousel-indicators'><li data-target='#myCarousel' data-slide-to='0' class=active'></li></ol><!--Wrapper for slides--><div id='projMedia' class='carousel-inner text-center' role='listbox'><div class='item active'></div></div><!--Left and right controls--><a class='left carousel-control' href='#myCarousel' role='button' data-slide='prev'><span class='glyphicon glyphicon-chevron-left' aria-hidden='true'></span><span class='sr-only'>Previous</span></a><a class='right carousel-control' href='#myCarousel' role='button' data-slide='next'><span class='glyphicon glyphicon-chevron-right' aria-hidden='true'></span><span class='sr-only'>Next</span></a></div ><div id='projDetails' class='col-sm-6 slide'></div>";
    display.style.display = 'block';

    document.body.scroll = "no";
    document.body.style.overflow = "hidden";
    document.getElementById("fade").style.display = "block";

    $.ajax({
        cache: false,
        type: "POST",
        url: "/Home/GetProjectData",
        data: {
            projectType: projectType,
            index: projectIndex
        },
        datatype: "json",
        success: function (result) {
            var projArray = JSON.parse(result);

            var projMedia = document.getElementById('projMedia');
            var displayInnerHTML = '';
            for (var i = 2; i < projArray.length; i++) {
                displayInnerHTML += '<div class="item ';
                if (i == 2) displayInnerHTML += 'active';
                displayInnerHTML += '">';
                if (projArray[i].includes('mp4')) {
                    displayInnerHTML += '<video controls><source src="' + projArray[i] + '" type="video/mp4">Your browser does not support the video tag. Sorry about that! Please try again in a more modern browser.</video></div>';
                }
                else {
                    displayInnerHTML += '<img src="' + projArray[i] + '" /></div>';
                }
            }
            projMedia.innerHTML = displayInnerHTML;

            var indicators = document.getElementById('projCarouselInds');
            displayInnerHTML = '';
            for (var i = 0; i < projArray.length - 2; i++) {
                displayInnerHTML += '<li data-target="#myCarousel" data-slide-to="' + i + '"';
                if (i == 0) displayInnerHTML += 'class="active" ';
                displayInnerHTML += '></li > ';
            }
            indicators.innerHTML = displayInnerHTML;

            displayInnerHTML = '<h4>' + projArray[0] + '</h4><p>' + projArray[1] + '</p>';
            document.getElementById('projDetails').innerHTML = displayInnerHTML;

            //display.style.marginTop = ((window.innerHeight - display.getBoundingClientRect().height) / 2) + "px";
        },
        error: function (xhr, status, error) {
            alert(error);
        }
    });
}

function CloseProject() {
    document.body.scroll = "yes";
    document.body.style.overflow = "scroll";

    document.getElementById("projectDisplay").style.display = "none";
    document.getElementById("projectDisplay").innerHTML = "";
    document.getElementById("fade").style.display = "none";
}
