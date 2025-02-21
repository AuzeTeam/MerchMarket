<script setup></script>

<template>
	<RouterLink className="crm" to="/crm">CRM</RouterLink>
	<RouterView />
</template>

<style>
@font-face {
	font-family: 'Raleway';
	src: url(../public/fonts/Raleway-VariableFont_wght.ttf);
}

#app {
	font-family: 'Raleway';
	font-size: 16px;
	font-weight: 300;
	color: #252525;
}

.crm {
	position: absolute;
}
.container {
	width: 82%;
	margin-inline: auto;
}

.button {
	background-color: #e0bea2;
	cursor: pointer;
	color: #fff;
	letter-spacing: 1.5px;
	transition: all 0.2s ease;
}

.button:hover {
	box-shadow: 0 5px 7px #25252515;
}

.button:active {
	box-shadow: inset 0 5px 7px #25252520;
}
</style>
