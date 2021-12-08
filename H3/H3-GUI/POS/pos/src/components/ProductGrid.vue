<template>
  <div class="wrapper">
    <div><ProductButton/></div>
    <div><ProductButton/></div>
    <div><ProductButton/></div>
    <div><ProductButton/></div>
    <div><ProductButton/></div>
    <div><ProductButton/></div>
    <div><ProductButton/></div>
    <div><ProductButton/></div>
    <div><ProductButton/></div>
    <div><ProductButton/></div>
    <div><ProductButton/></div>
    <div><ProductButton/></div>
  </div>
</template>

<script>
import ProductButton from "@/components/ProductButton.vue";

export default {
  name: "Home",
  components: {
    ProductButton,
  },
  data(){

  },
};
</script>

<style>
.wrapper {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  grid-auto-rows: 200px;
}
</style>