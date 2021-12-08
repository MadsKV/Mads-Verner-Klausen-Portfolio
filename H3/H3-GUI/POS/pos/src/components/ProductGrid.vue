<template>
  <div class="wrapper">
    <div v-for="p in Products" v-bind:key="p.Title">
      <ProductButton
        v-on:Bought="onbought"
        v-bind:Title="p.Title"
        v-bind:Price="p.Price"
        v-bind:Category="p.Category"
      />
    </div>
  </div>
  <div></div>
</template>

<script>
import ProductButton from "@/components/ProductButton.vue";

export default {
  name: "Home",
  components: {
    ProductButton,
  },
  props: ["Products"],
  data() {},
  methods: {
    onbought(Title, Price) {
      this.$emit("Bought", Title, Price);
    },
  },
};
</script>

<style>
body {
  background: rgb(68, 68, 68);
}
.wrapper {
  display: grid;
  grid-template-columns: repeat(5, 1fr);
  grid-auto-rows: 150px;
}
</style>