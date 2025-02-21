import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../pages/HomeView.vue'
import signIn from '../pages/sign-in.vue'
import signUp from '../pages/sign-up.vue'
import crm from '../pages/crm.vue'
import Catalog from '../pages/catalog.vue'
import Product from '../pages/product.vue'

const routes = [
	{ path: '/', component: HomeView },
	{ path: '/catalog', component: Catalog },
	{ path: '/catalog/product/:id', component: Product },
	{ path: '/sign-in', component: signIn },
	{ path: '/sign-up', component: signUp },
	{ path: '/crm', component: crm },
]

const router = createRouter({
	history: createWebHistory(),
	routes,
})

export default router
