$(document).ready(function() {
    _.each($('.film .release-date'), function (item) {
        try {
            var oneDay = 1000 * 60 * 60 * 24;
            var date = new Date($(item).text());
            var today = new Date().setHours(0);
            var countdown = Math.round((date.getTime() - today) / oneDay);
            $(item).siblings('.days-until-release').text(countdown);
            if (countdown < 0) {
                $(item).siblings('.status').text('Released');
            } else if (countdown < 366) {
                $(item).siblings('.status').text('Post-production');
            } else if (countdown < 732) {
                $(item).siblings('.status').text('Pre-production');
            } else {
                $(item).siblings('.status').text('In Development');
            }
        } catch(ex) {
            $(item).siblings('.days-until-release').text('TBA');
        }
    });
});
