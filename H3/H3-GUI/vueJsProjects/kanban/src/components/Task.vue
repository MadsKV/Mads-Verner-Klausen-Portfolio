<template>
  <div class="task" @mouseover="mouseOver" @mouseleave="mouseLeave" >
    <div v-if="editMode">
      <textarea v-model="task_desc" @blur="save"></textarea>
    </div>
    <div v-else>
      {{ task.description }}
      <button v-if="showEdit" @click="edit">Edit</button>
    </div>
  </div>
</template>

<script>
export default {
  props: ["task"],
  data() {
    return {
      editMode: false, //Viser knap
      showEdit: false, //Rediger tekst
      task_desc: "",
    };
  },
  methods: {
    save() {
      this.editMode = false;
    },
    edit() {
      this.editMode = true;
      this.task_desc = this.task.description;
    },
    mouseOver() {
      this.showEdit = true;
    },
    mouseLeave() {
      this.showEdit = false;
    },
  },
};
</script>


