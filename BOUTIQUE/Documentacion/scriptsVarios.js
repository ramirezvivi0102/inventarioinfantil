Usuario dentro de este sistema: ramirezvivi0102@gmail.com
isabella0102C*

===================		MIGRACIONES ============
--- Se habilitar por motivo de usar usuarios por defecto,
--- por ende:
1. Mostrar la ventana Package manager console, ir al menu: View / Other Windows /Package manager console 
2. Habilitar las migraciones: En la consola escribimos:
	PM> enable-migrations
3. Actualizar la base de datos (para que tablas de administracion de usuarios se creen en la bd)
	PM> update-database

======================   ACTUALIZAR LOS MODELOS DESDE CAMBIOS EN LA BD (DataBase First) ===================
    Scaffold-DbContext "server=localhost;port=3306;database=inventario;user=root;password=" Pomelo.EntityFrameworkCore.MySql -OutputDir Models -Context ApplicationDbContext -Force

