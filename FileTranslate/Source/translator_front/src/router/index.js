import Vue from 'vue'
import VueRouter from 'vue-router'


Vue.use(VueRouter)

const routes = [
  {
    path: '/home',
    name: 'Home',
    component: () => import('../views/Home.vue')
  },
  {
    path: '/hom3',
    name: 'Hom3',
    component: () => import('../views/Hom3.vue')
  },
  {
    path: '/',
    name: 'Login',
    component: () => import('../views/Login.vue')
 
  },
  {
    path: '/translator',
    name: 'Translator',
    component: () => import('../views/Translator.vue')
 
  },
  {
    path: '/nuevo',
    name: 'Nuevo',
    component: () => import('../views/Nuevo.vue')
  },
  {
    path: '/ListUser',
    name: 'ListUser',
    component: () => import('../views/ListUser.vue')
  },
  {
    path: '/ListUsers',
    name: 'ListUsers',
    component: () => import('../views/ListUsers.vue')
  }

  
]

const router = new VueRouter({
  routes
})

export default router
