create procedure insert_usuario
( @cedula int, @nombre varchar, @apellido varchar, @direccion varchar, @telefono integer, @correo varchar, @pass varchar, @uid varchar) as
begin

	if exists(SELECT * FROM usuarios where correo =@correo)
		begin
			return (1)
		end
	else
		begin
			insert into usuarios values (@cedula,@nombre,@apellido,@direccion,@telefono,@correo,@pass,@uid);
			return(0)
		end
end

create procedure update_usuario
( @nombre varchar, @apellido varchar, @direccion varchar, @telefono integer, @correo varchar, @pass varchar, @uid varchar) as
begin

	if exists(SELECT * FROM usuarios where correo =@correo)
		begin
			update usuarios set nombre =@nombre, apellido = @apellido ,direc = @direccion, telefono = @telefono, contraseña = @pass;
		return 0;
		end
	else
		begin
			return (1)
		end
end