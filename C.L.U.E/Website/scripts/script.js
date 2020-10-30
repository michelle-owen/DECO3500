var questionNo = 1;
   
$(document).ready(function() {
    questionNo = 1;
    $("#next").click(function() {
        goToByScroll("#answers");
    });

    $("#nextq").click(function() {
        goToByScroll("#questions");
        $(".q" + questionNo).css("display", "none");
        $(".q" + (questionNo + 1)).css("display", "block");
        questionNo += 1;
    });
});

function goToByScroll(id) {
    // Scroll
    $('html,body').animate({
        scrollTop: $(id).offset().top
    }, 'slow');
}