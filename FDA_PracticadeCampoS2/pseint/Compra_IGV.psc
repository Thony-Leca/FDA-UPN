Algoritmo Compra_IGV
	Definir name_producto Como Caracter
	Definir precio,igv,total_compra Como Real
	igv= 1.18
	Escribir "Genera tu compra"
	Escribir "Escribe el nombre del producto:"
	Leer name_producto
	Escribir "Escribe el precio del producto:"
	Leer precio
	total_compra= precio * igv
	Escribir "El total por tu producto llamado " name_producto " es S/ " total_compra " incluido IGV."
FinAlgoritmo
