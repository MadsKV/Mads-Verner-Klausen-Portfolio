<template>
  <div class="home"> <ProductGrid/></div>
</template>

<script>
// @ is an alias to /src

import ProductGrid from "@/components/ProductGrid.vue";

export default {
  name: "Home",
  components: {
    ProductGrid,
  },
  data() {
    return { Products: [] };
  },
  mounted() {
    const axios = require("axios").default;

    axios.get("/Products.json").then((Products) => (this.Products = Products));
  },
};
</script>
