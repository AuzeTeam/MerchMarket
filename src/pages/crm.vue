<script>
import Header from '../components/Header-white.vue'
export default {
	components: { Header },
	data() {
		return {
			product: [],
			error: '',
			productName: '',
			productPrice: '',
			productCount: '',
		}
	},
	methods: {
		sendProduct() {
			if (this.productName == '') {
				this.error = 'Имя товара не введено'
				return
			} else if (this.productPrice == '') {
				this.error = 'Цена товара не введено'
				return
			} else if (this.productCount == '') {
				this.error = 'Количество товара не введено'
				return
			}

			this.error = ''

			this.product.push({
				name: this.productName,
				price: this.productPrice,
				count: this.productCount,
			})
		},
	},
}
</script>

<template>
	<article className="product-crm">
		<img src="../img/crm-item1.jpg" alt="" />
		<h3>Название</h3>
		<h4>Размеры</h4>
		<span>Колл</span>
		<h5>Цена</h5>
	</article>
	<!-- <div v-for="(el, index) in product" :key="index" className="item">
		<h3>Название товара: {{ el.name }}</h3>
		<h3>Цена: {{ el.price }} ₽</h3>
		<h3>Количество товара: {{ el.count }} шт</h3>
	</div> -->
	<div className="crm-input"></div>
	<h2>Товары</h2>
	<div>
		<label>Наименование:</label>
		<input type="text" v-model="productName" placeholder="Наименование" />
	</div>
	<div>
		<label>Цена:</label>
		<input type="number" v-model="productPrice" placeholder="Цена" />
	</div>
	<div>
		<label>Количество:</label>
		<input type="number" v-model="productCount" placeholder="Количество" />
	</div>
	<p>{{ error }}</p>
	<button @click="sendProduct">Создать товар</button>
</template>

<style scoped>
.product-crm {
	display: flex;
	align-items: center;
}
.crm-input {
	display: flex;
	flex-direction: column;
	margin-top: 10px;
	margin-left: 10px;
}

label {
	margin-bottom: 4px;
}

input {
	padding: 5px 10px;
	border-radius: 2px;
	outline: none;
	border: 1px solid gray;
	width: 300px;
}

button {
	cursor: pointer;
	color: #fff;
	width: 150px;
	margin-top: 20px;
	margin-left: 10px;
	padding: 5px 10px;
	border: 2px solid rgb(58, 103, 252);
	border-radius: 5px;
	background-color: rgb(87, 138, 250);
}
</style>
