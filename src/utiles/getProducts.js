export async function getProducts() {
	const data = await fetch('https://67a5e90b510789ef0df9b1fc.mockapi.io/products/').then(e => e.json())
	return data
}
