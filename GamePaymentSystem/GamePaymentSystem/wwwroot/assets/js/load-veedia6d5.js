var _v, settings = {
  game: veediGameName, // Game name (Variable)
  publisherId: 74653666,     // Publisher ID (provided by our side)
  onVideoFound: function () {    // perform an action if video found
    ga('send', 'event', 'walkthrough', 'Veedi-Loaded', veediGameSlug, {
      nonInteraction: true
    });
  },
  onVideoNotFound: function () {  // perform an action if video NOT found
    ga('send', 'event', 'walkthrough', 'Veedi-NOTFOUND', veediGameSlug, {
      nonInteraction: true
    });
  },
  onError: function () {
    ga('send', 'event', 'walkthrough', 'Veedi-ERROR', veediGameSlug, {
      nonInteraction: true
    });
  },
  onFullscreen: function () {
    ga('send', 'event', 'walkthrough', 'Veedi-FULLSCREEN', veediGameSlug);
  },
  width: gameContainerWidth - 30 // Veedi player width

};
(function (settings) {
  var vScript = document.createElement('script');
  vScript.type = 'text/javascript';
  vScript.async = true;
  vScript.src = '//www.veedi.com/player/embed/veediEmbed.js';
  vScript.onload = function () {
    _v = new VeediEmbed(settings);
    // auto play the video
    _v.play()
  };
  var veedi = document.getElementById('veediInit');
  veedi.parentNode.insertBefore(vScript, veedi);
})(settings);
