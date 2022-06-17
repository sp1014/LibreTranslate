<template>
 <div>
<Header/>
<br/>
 <h3> Hello {{admin}}, {{data.name}}</h3> 
  <br/>

 </div>
</template>

<script>

import Header from '@/components/Header'
   export default {
     components:{
       Header
     },
    
    data () {
      return {
        admin: ''
      
       
      }
    },
 
     computed:{
        data(){
          if (this.$store.state.data.data.idRol==1){
            this.admin = "Administrator"
          }else{
            this.admin = "User"
          }
          return this.$store.state.data.data;
        }
      }
  }
</script>
