let GameManager = {
  setGameStart: function (classType) {
    this.resetPlayer(classType);
    this.setPreFight();
  },
  resetPlayer: function (classType) {
    switch (classType) {
      case "Warrior":
        player = new Player(classType, 300, 0, 150, 90, 150, 150, 100);
        break;

      case "Warlock":
        player = new Player(classType, 150, 300, 45, 70, 120, 100, 100);
        break;

      case "Shaman":
        player = new Player(classType, 240, 250, 75, 150, 150, 100, 100);
        break;

      case "Rogue":
        player = new Player(classType, 150, 100, 40, 200, 200, 180, 100);
        break;

      case "Priest":
        player = new Player(classType, 130, 350, 20, 45, 80, 100, 100);
        break;

      case "Paladin":
        player = new Player(classType, 270, 280, 110, 85, 100, 140, 100);
        break;

      case "Monk":
        player = new Player(classType, 180, 90, 60, 180, 230, 120, 100);
        break;

      case "Mage":
        player = new Player(classType, 120, 350, 20, 35, 120, 120, 100);
        break;

      case "Hunter":
        player = new Player(classType, 150, 100, 90, 180, 130, 150, 100);
        break;

      case "Druid":
        player = new Player(classType, 200, 200, 65, 100, 110, 100, 100);
        break;

      case "Demon Hunter":
        player = new Player(classType, 230, 140, 110, 110, 110, 100, 100);
        break;

      case "Death Knight":
        player = new Player(classType, 260, 90, 130, 95, 130, 120, 100);
        break;
    }
    let getInterface = document.querySelector(".interface");
    getInterface.innerHTML =
      '<img src="images/Heroes/' +
      classType.toLowerCase() +
      '.png" class="img-avatar"><div><h3>' +
      classType +
      "</h3><p>health: " +
      player.health +
      "</p><p>mana: " +
      player.mana +
      "</p><p>strength: " +
      player.strength +
      "</p><p>agility: " +
      player.agility +
      "</p><p>speed: " +
      player.speed +
      "</p><p>stamina: " +
      player.stamina +
      "</p><p>charge: " +
      player.charge +
      "</p></div>";
  },
  setPreFight: function () {
      let getHeader = document.querySelector(".header");
      let getActions = document.querySelector(".actions");
      let getArena = document.querySelector(".arena");

      getHeader.innerHTML = '<p>Task: Find an enemy!</p>';
      getActions.innerHTML = '<a href="#" class="btn-prefight" onclick="GameManager.setFight()">Search for enemy</a>';
      getArena.style.visibillity = "visible";
  },
  setFight: function() {
    let getHeader = document.querySelector(".header");
    let getActions = document.querySelector(".actions");
    let getEnemy = document.querySelector(".enemy");

    let enemy00 = new Enemy();
  }

};
