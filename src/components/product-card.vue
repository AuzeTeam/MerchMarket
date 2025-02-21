<script setup>
import { watch, ref, defineProps } from 'vue'
import { RouterLink } from 'vue-router'
const props = defineProps({
	key: String,
	img: String,
	name: String,
	price: String,
})
</script>

<template>
	<RouterLink :to="`/catalog/product/${props.key}`" class="product">
		<div :key="props.key">
			<img :src="props.img" alt="" />
			<h4>{{ props.name }}</h4>
			<h5>{{ props.price }} ₽</h5>
			<span>S M L XL</span>
		</div>
	</RouterLink>
</template>

<style scoped>
.product {
	display: flex;
	flex-direction: column;
	align-items: center;
	margin-top: 30px;
}

.product img {
	height: 300px;
	width: 250px;
}
.product h4 {
	margin-top: 5px;
}

.product h5 {
	margin: 5px 0;
	font-weight: 700;
}

.product span {
	color: #25252550;
}
</style>
