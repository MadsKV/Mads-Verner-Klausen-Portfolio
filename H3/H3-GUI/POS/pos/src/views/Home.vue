<template>
  <div class="home"></div>
</template>

<script>
// @ is an alias to /src

export default {
  name: "Home",
  components: {},
  data() {
    return { Products: [] };
  },
  mounted() {
    const axios = require("axios").default;

    axios.get("/Products.json").then((Products) => (this.Products = Products));
  },
};
</script>
