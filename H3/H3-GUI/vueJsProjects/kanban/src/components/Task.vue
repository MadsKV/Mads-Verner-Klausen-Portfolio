<template>
  <div class="task" @mouseover="mouseOver" @mouseleave="mouseLeave">
    <div v-if="editMode">
      <textarea v-model="task_desc" @blur="save" id="editTask"></textarea>
    </div>
    <div v-else>
      {{ task.description }}
      <button v-if="showEdit" @click="edit">Edit</button>
      <button v-if="showEdit" @click="remove">Delete</button>
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
      this.$emit("taskSaved", {
        id : this.task.id,
        new_text : this.task_desc
      });
    },
    remove() {
      if (confirm("Vil du slette opgaven?")){
        this.$emit("taskRemoved", {
          id : this.task.id
        })
      }
    },
    edit() {
      this.editMode = true;
      this.task_desc = this.task.description;
      document.getElementById["editTask"].focus()
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


