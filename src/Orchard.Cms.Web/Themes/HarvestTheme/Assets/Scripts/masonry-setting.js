// the main masonry jquery setting to call the masonry script
jQuery(window).on("load", function () {
   jQuery('#container').masonry({
      itemSelector: '.post-container'
   });
});