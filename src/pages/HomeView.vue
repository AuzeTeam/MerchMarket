<script setup>
import Header from '../components/Header-white.vue'
import Footer from '../components/Footer.vue'
</script>

<template>
	<main>
		<section className="section-wrapper">
			<Header></Header>
			<h2>Новая коллекция</h2>
			<hr />
			<div className="flex">
				<RouterLink to="/catalog">СМОТРЕТЬ НОВИНКИ <img src="../img/Vector.svg" alt="" /></RouterLink>
			</div>
		</section>
		<div className="container">
			<section className="section">
				<h3>Категории</h3>
				<div className="items">
					<article><img src="../img/main/item1.jpg" alt="" /></article>
					<article><img src="../img/main/item2.jpg" alt="" /></article>
					<article><img src="../img/main/item3.jpg" alt="" /></article>
					<article><img src="../img/main/item4.jpg" alt="" /></article>
				</div>
			</section>
			<section className="section section-email">
				<h3>Узнайте первым о новинках</h3>
				<div>
					<input type="email" placeholder="Ваш email" />
					<button className="button">ПОДПИСАТЬСЯ</button>
					<p>Нажимая на кнопку «Подписаться», я соглашаюсь на обработку моих персональных данных и ознакомлен(а) с условиями конфиденциальности.</p>
				</div>
			</section>
		</div>
	</main>
	<Footer></Footer>
</template>

<style scoped>
a {
	color: #fff;
}

.section-wrapper {
	height: 120vh;
	text-align: center;
	background-image: url('../img/main/background-main.jpg');
	background-size: cover;
	background-repeat: no-repeat;
}

.section-wrapper h2 {
	font-size: 46px;
	font-weight: 300;
	margin: 280px auto 0;
	color: #fff;
}

.section-wrapper hr {
	width: 10%;
	margin: 25px auto;
}

.section-wrapper img {
	cursor: pointer;
	margin-left: 5px;
}

.section-wrapper a {
	position: relative;
}

.section-wrapper a img {
	position: absolute;
	right: -15px;
	top: 4px;
}

.section {
	margin-top: 100px;
}

.section h3 {
	font-size: 36px;
	margin-bottom: 40px;
}

.items {
	display: flex;
	justify-content: space-between;
}

.section-email h3 {
	text-align: center;
}

.section-email div {
	display: flex;
	flex-direction: column;
}

.section-email input {
	height: 40px;
	width: 50%;
	margin-inline: auto;
	border: solid 1px #252525;
	padding-inline: 10px;
}

.section-email input::placeholder {
	text-align: center;
}

.section-email .button {
	margin: 15px 0;
	height: 40px;
	width: 50%;
	margin-inline: auto;
}

.section-email p {
	text-align: center;
	font-weight: 200;
	width: 50%;
	margin-inline: auto;
}
</style>
