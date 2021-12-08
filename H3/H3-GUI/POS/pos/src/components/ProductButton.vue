<template>
  <div class="posbutton" v-bind:class="color">
    <button v-on:click="$emit('Bought', Title, Price)">
      {{ Title }} {{ Price }}
    </button>
  </div>
</template>

<script>
export default {
  props: ["Title", "Price", "Category"],
  computed: {
    color() {
      switch (this.Category) {
        case "Food":
          return "red";
        case "Bevrage":
          return "green";
        case "Misc":
          return "light-blue";
        case "Soda":
          return "blue"
        case "Godter":
          return "blue"
        default:
          return "";
      }
    },
  },
};
</script>

<style>
div.posbutton{
  display:inline-block;
  margin-left: auto;
  vertical-align: top;
  margin: 0.5%;

  border: 0px;
  height: 20vh;
  cursor: pointer;
  position: relative;

  width: 19%;
  color: white;
  border-radius: 5px 5px 5px 5px;
}

.red {
  height: 70px;
  border-radius: 15px;
  padding: 10px;
  margin: 5px;
  background: linear-gradient(
    rgb(255, 68, 68) 0%,
    rgb(255, 0, 0) 35%,
    rgb(238, 0, 0) 100%
  );
}

.yellow {
  height: 70px;
  border-radius: 15px;
  padding: 10px;
  margin: 5px;
  background: linear-gradient(
    rgb(193, 193, 68) 0%,
    rgb(170, 170, 0) 35%,
    rgb(159, 159, 0) 100%
  );
}

.blue {
  height: 70px;
  border-radius: 15px;
  padding: 10px;
  margin: 5px;
  background: linear-gradient(
    rgb(68, 68, 255) 0%,
    rgb(0, 0, 255) 35%,
    rgb(0, 0, 238) 100%
  );
}

.light-blue {
  height: 70px;
  border-radius: 15px;
  padding: 10px;
  margin: 5px;
  background: linear-gradient(
    rgb(0, 204, 204) 0%,
    rgb(0, 170, 170) 35%,
    rgb(0, 159, 159) 100%
  );
}

.green {
  height: 70px;
  border-radius: 15px;
  padding: 10px;
  margin: 5px;
  background: linear-gradient(
    rgb(68, 218, 68) 0%,
    rgb(0, 204, 0) 35%,
    rgb(0, 190, 0) 100%
  );
}
</style>