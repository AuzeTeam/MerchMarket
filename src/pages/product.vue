<script setup>
import Header from '../components/Header-beige.vue'
import Footer from '../components/Footer.vue'

const props = defineProps({
	key: String,
})
//тут настроить кароче и все
const data = ref([])

watch(async () => {
	const response = await fetch(`https://67a5e90b510789ef0df9b1fc.mockapi.io/products/${props.key}}`)
	data.value = await response.json()
})
</script>

<template>
	<div className="container">
		<Header></Header>
		<div className="history">
			<RouterLink to="/">Главная</RouterLink>
			<svg width="7" height="10" viewBox="0 0 7 10" fill="none" xmlns="http://www.w3.org/2000/svg">
				<path d="M3.88906 5L0 1.11094L1.11094 0L6.11094 5L1.11094 10L0 8.88906L3.88906 5Z" fill="#e0bea2" />
			</svg>
			<RouterLink to="/catalog">Каталог</RouterLink>
			<svg width="7" height="10" viewBox="0 0 7 10" fill="none" xmlns="http://www.w3.org/2000/svg">
				<path d="M3.88906 5L0 1.11094L1.11094 0L6.11094 5L1.11094 10L0 8.88906L3.88906 5Z" fill="#e0bea2" />
			</svg>
			<RouterLink to="/catalog">Куртка</RouterLink>
		</div>
	</div>
	<Footer></Footer>
</template>

<style scoped>
.history {
	margin: 10px 0 25px;
	display: flex;
	gap: 7px;
}
</style>
