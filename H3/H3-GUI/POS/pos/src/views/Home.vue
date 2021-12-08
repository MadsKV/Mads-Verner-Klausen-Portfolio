<template>
  <div class="home"> <ProductGrid v-bind:Products="Products" v-on:Bought='onbought'/></div>
  {{sum}}
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
    return { Products: [], sum:0};
  },
  mounted() {
    const axios = require("axios").default;

    axios.get("/Products.json").then((response) => (this.Products = response.data));
  },
  methods:{
    onbought(Title, Price){
      this.sum += parseInt(Price)
    }
  },
};
</script>
