class AudioFiles {
  constructor() {}

  setupAudio() {
    var audioFiles = [
      "Fox Stevenson - Go Like (D&B Mix).mp3",
      "Ninjaneers -I just wanna smile.mp3",
      "Syn Cole - Feel Good.mp3",
      "Alan Walker - Spectre.mp3",
      "DEAF KEV - Invincible.mp3",
    ];

    var i = 0;

    var music_player = document.querySelector("#music_list audio");

    function next() {
      if (i === audioFiles.length - 1) {
        i = 0;
      } else {
        i++;
      }

      music_player.src = audioFiles[i];
    }

    if (music_player === null) {
      throw "Playlist Player does not exists ...";
    } else {
      music_player.src = audioFiles[i];

      music_player.addEventListener("ended", next, false);
    }
  }
}
