<template>
  <body>
    <div class="container">
      <div class="kanban-heading">
        <h1 class="neon" data-text="U">KAN<span class="flicker-slow">BA</span>N <span class="flicker-fast">BO</span>ARD</h1>
      </div>
      <div class="kanban-board">
        <div class="kanban-block" id="backlog">
          <column id="backlog" :title="'Backlog'"></column>
        </div>
        <div class="kanban-block" id="todo">
          <column id="todo" :title="'Todo'"></column>
        </div>
        <div class="kanban-block" id="inprogress">
        <column id="inprogress" :title="'Work in progress'"></column>
        </div>
        <div class="kanban-block" id="done">
        <column id="done" :title="'Done'"></column>
        </div>
      </div>
    </div>
  </body>
</template>

<script>
import Column from "@/components/Column.vue";
export default {
  components: {
    column: Column,
  },
  data() {
    return {
      /* 
      todo : [{id : 1, description "lav noget"}],
      todo : [{id : 2, description "lav noget andet"}],
      todo : [{id : 3, description "lav noget tredje"}]
      */
    };
  },
};
</script>












<style>



body {
  background-color: black;
}



.container {
  width: 70%;
  min-width: 50%;
  margin: auto;
  display: flex;
  flex-direction: column;
}

.kanban-heading {
  display: flex;
  flex-direction: row;
  justify-content: center;
  font-family: sans-serif;
}

/*
  .kanban-heading-text {
  font-size: 1.8rem;
  background-color: tomato;
  padding: 0.8rem 1.7rem;
  border-radius: 0.5rem;
  margin: 1rem;
  */

.kanban-board {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  font-family: sans-serif;
}

.kanban-block {
  padding: 0.6rem;
  width: 30.5%;
  min-width: 14rem;
  min-height: 4.5rem;
  border-radius: 0.3rem;
  font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;
  font-size: 18px;
  font-style: oblique;
}
#backlog {
  background-color: #c7c7c7;
}
#todo {
  background-color: #fec6d1;
}

#inprogress {
  background-color: #ffaf00;
}

#done {
  background-color: #00c400;
}
body{
  background: #000;
}
.neon{
  font-family: 'Monoton', cursive;
  font-size:35px;
  color: #FFD5FF;
  font-weight: 400;
  letter-spacing: 8px;
  text-shadow: 1px 0px 4px #FFD5FF, 2px 0px 4px #FFD5FF, 3px 0px 4px #FFD5FF, 2px 0px 3px #D42CCA, 2px 3px 15px #D42CCA, 2px 0px 15px, 5px 0px 125px, 20px 0vw 200px #D42CCA,40px 0vw 200px #D42CCA;
}
.flicker-slow{
  animation: flicker 3s linear infinite;
}
.flicker-fast{
  animation: flicker 1s linear infinite;
}
@keyframes flicker {
	0%, 19.999%, 22%, 62.999%, 64%, 64.999%, 70%, 100% {
		//text-shadow: none;
    opacity: .99;
		
	}
	20%, 21.999%, 63%, 63.999%, 65%, 69.999% {
		opacity: 0.4;
	}
}
</style>
