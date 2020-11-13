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

    getHeader.innerHTML = "<p>Task: Find an enemy!</p>";
    getActions.innerHTML =
      '<a href="#" class="btn-prefight" onclick="GameManager.setFight()">Search for enemy</a>';
    getArena.style.visibillity = "visible";
  },
  setFight: function () {
    let getHeader = document.querySelector(".header");
    let getActions = document.querySelector(".actions");
    let getEnemy = document.querySelector(".enemy");

    let enemy00 = new Enemy("Bear", 120, 0, 50, 100, 90, 100, 100);
    let enemy01 = new Enemy("Dark Elver", 80, 90, 70, 40, 120, 100, 100);
    let enemy02 = new Enemy("Dwarf", 140, 100, 120, 40, 75, 100, 100);
    let enemy03 = new Enemy("Half Orc", 200, 70, 60, 40, 80, 100, 100);
    let enemy04 = new Enemy("Nerubian", 180, 200, 65, 80, 120, 100, 100);
    let enemy05 = new Enemy("Night Elver", 90, 150, 80, 60, 100, 100, 100);
    let enemy06 = new Enemy("Orc", 200, 50, 80, 40, 110, 100, 100);
    let enemy07 = new Enemy("Tauren", 350, 80, 40, 60, 80, 100, 100);
    let enemy08 = new Enemy("Warewolf", 165, 110, 80, 150, 120, 100, 100);
    let enemy08 = new Enemy("Warewolf", 165, 110, 80, 150, 120, 100, 100);
    let enemy09 = new Enemy("Fire Elemental", 180, 110, 65, 95, 120, 100, 100);

    let chooseRandomEnemy = Math.floor(Math.random() * Math.floor(10));

    switch (chooseRandomEnemy) {
      case 0:
        enemy = enemy00;
        break;
      case 1:
        enemy = enemy01;
        break;
      case 2:
        enemy = enemy02;
        break;
      case 3:
        enemy = enemy03;
        break;
      case 4:
        enemy = enemy04;
        break;
      case 5:
        enemy = enemy05;
        break;
      case 6:
        enemy = enemy06;
        break;
      case 7:
        enemy = enemy07;
        break;
      case 8:
        enemy = enemy08;
        break;
      case 9:
        enemy = enemy09;
        break;
    }
    getHeader.innerHTML = "<p>Task: Choose your move</p>";
    getActions.innerHTML =
      '<a href="#" class="btn-prefight" onclick="PlayerMoves.calcAttack()">Attack</a>';
    getEnemy.innerHTML =
      '<img src="images/enemies/' +
      enemy.enemyType.toLowerCase() +
      '.png" alt="' +
      enemy.enemyType +
      '"class="img-avatar><div><h3>' +
      enemy.enemyType +
      '</h3><p class="health-enemy">Health: ' +
      enemy.health +
      "</p><p>Mana: " +
      enemy.mana +
      "</p><p>Strength: " +
      enemy.strength +
      "</p><p>Agility: " +
      enemy.agility +
      "</p><p>Speed: " +
      enemy.speed +
      "</p></div>";
  },
};
