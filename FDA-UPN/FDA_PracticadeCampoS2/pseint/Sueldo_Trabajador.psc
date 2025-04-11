Algoritmo Sueldo_Trabajador
	Definir s_bruto, d_afp, s_neto Como Real
	Escribir "Calcula tu sueldo"
	Escribir "Ingresa tu sueldo bruto(sin descuentos):"
	Leer s_bruto
	Si s_bruto > 3000
		Entonces d_afp= 0.13
	SiNo
		d_afp = 0.11
	FinSi
	s_neto=  s_bruto - (s_bruto * d_afp)
	Escribir "Tu sueldo a recibir es: S/ " s_neto " en donde estas aportado a tu AFP el monto de S/ " s_bruto - s_neto
FinAlgoritmo
