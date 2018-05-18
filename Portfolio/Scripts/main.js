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


// Shows the project display
function DisplayProject(projectType, projectIndex) {
    // Sets up all of the default html for the display
    var display = document.getElementById('projectDisplay');
    display.innerHTML = "<div id='myCarousel' class='carousel slide col-sm-6' data-ride='carousel' data-interval='false'><!--Indicators--><ol id='projCarouselInds' class='carousel-indicators'><li data-target='#myCarousel' data-slide-to='0' class=active'></li></ol><!--Wrapper for slides--><div id='projMedia' class='carousel-inner text-center' role='listbox'><div class='item active'></div></div><!--Left and right controls--><a class='left carousel-control' href='#myCarousel' role='button' data-slide='prev'><span class='glyphicon glyphicon-chevron-left' aria-hidden='true'></span><span class='sr-only'>Previous</span></a><a class='right carousel-control' href='#myCarousel' role='button' data-slide='next'><span class='glyphicon glyphicon-chevron-right' aria-hidden='true'></span><span class='sr-only'>Next</span></a></div ><div id='projDetails' class='col-sm-6 slide'></div>";
    display.style.display = 'block';

    // Locks scrolling for the page and shows the fade
    document.body.scroll = "no";
    document.body.style.overflow = "hidden";
    document.getElementById("fade").style.display = "block";

    // Calls a back end function to grab the appropriate project data
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
            // parses the json returned into an array of strings
            var projArray = JSON.parse(result);

            // Goes through all of the media data and sets up the carousel
            var projMedia = document.getElementById('projMedia');
            var displayInnerHTML = '';
            for (var i = 2; i < projArray.length; i++) {
                displayInnerHTML += '<div class="item ';
                if (i == 2) displayInnerHTML += 'active';
                displayInnerHTML += '" onclick="MediaZoom();">';
                if (projArray[i].includes('mp4')) {
                    displayInnerHTML += '<video controls><source src="' + projArray[i] + '" type="video/mp4">Your browser does not support the video tag. Sorry about that! Please try again in a more modern browser.</video></div>';
                }
                else if (projArray[i].includes('http')) {
                    displayInnerHTML += '<iframe width="650" height="360" src="' + projArray[i] + '" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe></div>'
                }
                else {
                    displayInnerHTML += '<img src="' + projArray[i] + '" /></div>';
                }
            }
            projMedia.innerHTML = displayInnerHTML;

            // Sets up the indicator bar for the carousel
            var indicators = document.getElementById('projCarouselInds');
            displayInnerHTML = '';
            for (var i = 0; i < projArray.length - 2; i++) {
                displayInnerHTML += '<li data-target="#myCarousel" data-slide-to="' + i + '"';
                if (i == 0) displayInnerHTML += 'class="active" ';
                displayInnerHTML += '></li > ';
            }
            indicators.innerHTML = displayInnerHTML;

            // Adds the description for the project to the view
            displayInnerHTML = '<h4>' + projArray[0] + '</h4><p>' + projArray[1] + '</p>';
            document.getElementById('projDetails').innerHTML = displayInnerHTML;
        },
        error: function (xhr, status, error) {
            alert(error);
        }
    });
}

// Closes the project view display
function CloseProject(e) {
    if (e.target.id !== 'fade' && e.target.id !== 'projectDisplay') return;
    document.body.scroll = "yes";
    document.body.style.overflow = "scroll";

    document.getElementById("projectDisplay").style.display = "none";
    document.getElementById("projectDisplay").innerHTML = "";
    document.getElementById("fade").style.display = "none";
}

// Zooms in or out of the project media
function MediaZoom() {
    var projDetails = document.getElementById('projDetails');
    // If not zoomed in already
    if (projDetails.style.display != "none") {
        // Sets up all the necessary css to allow for the media images to be focused on
        projDetails.style.display = "none";
        var items = document.getElementsByClassName('item');
        for (var i = 0; i < items.length; i++) {
            items[i].firstElementChild.style.maxWidth = "1000px";
            items[i].firstElementChild.style.maxHeight = "900px";
        }
        var projMedia = document.getElementById('myCarousel');
        projMedia.style.display = "inline-block";
        projMedia.style.position = "relative";
        projMedia.style.width = "100%";
        projMedia.style.textAlign = "center";
        projMedia.style.cssFloat = "none";
    }
    else {  // If already zoomed in
        // Clears all of the custom set css properties from when the user zoomed in
        projDetails.style.display = "";
        var items = document.getElementsByClassName('item');
        for (var i = 0; i < items.length; i++) {
            items[i].firstElementChild.style.maxWidth = "";
            items[i].firstElementChild.style.maxHeight = "";
        }
        var projMedia = document.getElementById('myCarousel');
        projMedia.style.display = "";
        projMedia.style.position = "";
        projMedia.style.width = "";
        projMedia.style.textAlign = "";
        projMedia.style.cssFloat = "";
    }
}