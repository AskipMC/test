<template>
    <div>
      Connecté à l API : {{ connected }}
    </div>
  </template>
  
  <script lang="ts">
  import { Component, Prop, Vue } from 'vue-property-decorator';
  import axios from 'axios'
  
  @Component
  export default class Test extends Vue {
    isAlive = false;

    async mounted(){

        await axios.get("http://localhost:5163/Test/IsAlive")
                .then(r => this.isAlive = r.data )
                .catch(error => this.isAlive = false)
        
    }
    get connected(){
        return this.isAlive ? 'Oui' : 'Non';
    }
  }
  </script>
  