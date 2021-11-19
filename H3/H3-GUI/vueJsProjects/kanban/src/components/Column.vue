                            <template>
  <div class="column col-3">
    <div class="taskBtn">
      <button @click="add">Add</button>
      <input
        type="text"
        placeholder="Enter Task"
        @keyup.enter="add"
        v-model="new_task_desc"
      />
    </div>
    <div class="kanban-block-assign">
      {{ title }}
    </div>
    <draggable
      v-model="tasks"
      group="task"
      @start="drag = true"
      @end="drag = false"
      @change="changed"
      item-key="id"
      ghost-class="ghost"
      class="fill-height"
    >
      <template #item="{ element }">
        <task :task="element" />
      </template>
    </draggable>
  </div>
</template>

                            <script>
import draggable from "vuedraggable";
import PouchDB from "pouchdb-browser";
import task from "@/components/Task.vue";

export default {
  components: {
    draggable,
    task,
  },
  props: {
    title: String,
  },
  data() {
    return {
      new_task_desc: "",
      rev: "",
      tasks: [],
      drag: false,
    };
  },
  mounted() {
    this.load();
  },
  methods: {
    add() {
      var new_task = {
        id: 100,
        description: this.new_task_desc,
      };
      this.tasks.push(new_task);
      this.new_task_desc = "";
      this.save();
    },
    save() {
      var db = new PouchDB("Kanban");
      db.put({
        _id: "task_" + this.title,
        _rev: this.rev,
        tasks: this.tasks,
      }).then((response) => {
        this.rev = response.rev;
      });
    },
    load() {
      var db = new PouchDB("Kanban");
      db.get("task_" + this.title)
        .then((result) => {
          this.tasks = result.tasks;
          this.rev = result._rev;
        })
        .catch(() => {});
    },
    changed() {
      this.save();
    },
  },
};
</script>









<style>
.kanban-block-assign {
  font-size: 30px;
  text-align: center;
  font-family: fantasy;
}

.column {
  height: 600px;
}

div.task {
  border: 1px rgb(0, 0, 0) solid;
  min-height: 100px;
}

div.ghost {
  opacity: 0.5;
}

.fill-height {
  height: 100%;
}
</style>
