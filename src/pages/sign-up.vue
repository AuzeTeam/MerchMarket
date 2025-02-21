<script></script>

<template>
	<div className="container">
		<div className="signIn">
			<h2>Sign Up</h2>
			<h5>Sign up for free to access to in any of our products</h5>
			<a className="social_network" href="https://www.google.ru/"
				>Continue With Google</a
			>
			<a className="social_network" href="https://twitter.com/"
				>Continue With Twitter</a
			>
			<span className="or">OR</span>
			<label>User name or email address</label>
			<input type="text" />
			<label>Password</label>
			<input type="password" />
			<button>Sign In</button>
			<h5>
				Don’t have an account? <RouterLink to="/sign-up">Sign up</RouterLink>
			</h5>
		</div>
		<img src="../img/signUp.jpg" alt="" />
	</div>
</template>

<style scoped>
.container {
	display: flex;
	flex-direction: row;
	height: 100vh;
	width: 100vw;
}

.container img {
	height: 92%;
	width: 35%;
}

.signIn {
	width: 40%;
	margin-inline: auto;
	display: flex;
	flex-direction: column;
}

.signIn h2 {
	font-size: 34px;
	margin-top: 50px;
}

.signIn .social_network {
	font-size: 15px;
	font-weight: 500;
	color: #8a33fd;
	text-decoration: none;
	width: 100%;
	text-align: center;
	border: 1px solid gray;
	border-radius: 8px;
	padding: 10px 0;
	margin-bottom: 15px;
}
.or {
	text-align: center;
	font-size: 14px;
	color: #666666;
	margin: 16px 0;
}

label {
	color: #3c4242;
	font-size: 13px;
	margin-bottom: 5px;
}

input {
	margin-bottom: 20px;
	padding: 12px 10px;
	outline: none;
	border: 1px solid #3c4242;
	border-radius: 6px;
}

button {
	color: #fff;
	border: none;
	padding: 12px 0;
	background-color: #8a33fd;
	width: 167px;
	border-radius: 7px;
	cursor: pointer;
}

.signIn h5 {
	font-weight: 400;
}
</style>
