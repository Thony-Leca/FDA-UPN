Algoritmo Promedio_Notas
	Definir cantidad_alumnos,cantidad_aprobados,cantidad_desaprobados Como Entero
	Definir n1,n2,n3,n4,promedio, porcen_aprobados, porcen_desaprobados Como Real
	cantidad_aprobados = 0
	cantidad_desaprobados = 0
	Escribir "Ingresa la cantidad de alumnos a calificar:"
	Leer cantidad_alumnos
	Para  i desde 1 hasta cantidad_alumnos
		Escribir "Ingresa la nota de la practica calificada del estudiante " i
		Leer n1
		Escribir "Ingresa la nota de la actitudinal del estudiante " i
		Leer n2
		Escribir "Ingresa la nota de los trabajos del estudiante " i
		Leer n3
		Escribir "Ingresa la nota del examen del estudiante " i
		Leer n4
		promedio= n1*0.15 + n2 * 0.10 + n3 * 0.25 + n4 * 0.5
		Si promedio >= 12 Entonces
			cantidad_aprobados = cantidad_aprobados + 1
		SiNo
			cantidad_desaprobados = cantidad_desaprobados + 1
		FinSi
		porcen_aprobados = (cantidad_aprobados / cantidad_alumnos) * 100
		porcen_desaprobados = (cantidad_desaprobados / cantidad_alumnos) * 100
	FinPara
	Escribir "Según lo ingresado, la cantidad de alumnos aprobados es: " cantidad_aprobados " y la cantidad de alumnos desaprobados es: " cantidad_desaprobados " teniendo como porcentajes un " porcen_aprobados "% y " porcen_desaprobados "% respectivamente."
FinAlgoritmo
