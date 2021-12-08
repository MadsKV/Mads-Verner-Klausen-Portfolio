<template>
  <div>
    <button v-on:click ="$emit('Bought' ,Title, Price)"> {{Title}} {{Price}} </button>
  </div>
</template>

<script>
export default {
  props: ["Title", "Price"],
};
</script>

<style>
</style>