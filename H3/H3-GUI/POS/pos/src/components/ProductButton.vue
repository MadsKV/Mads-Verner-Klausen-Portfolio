<template>
  <div>
    <button v-on="click"> Add </button>
  </div>
</template>

<script>
export default {
  props: ["Title", "Price"],
};
</script>

<style>
</style>