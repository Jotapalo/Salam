import sqlite3 as sql

class IODatabase:
    def __init__(self):
        pass

    def InserNewUser(self, userName: str, userPassword: str, userRol: str, userImg=None, database="DB_usuarios.db", table="users") -> None:
        """Insertar un nuevo usuario en la base de datos

        Args:
            userName (str): Nombre del nuevo usuario
            userPassword (str): Contraseña del nuevo usuario
            userRol (str): Rol del nuevo usuario
            userImg (Image, optional): Archivo en formato de imagen (png, jpg). Defaults to None.
            database (str, optional): Nombre de la base de datos. Defaults to "DB_usuarios.db"
            table (str, optional): Nombre de la tabla. Defaults to "users"

        Raises:
            ValueError: Valores de paramteros vacios, todos los valores tienen que tener un valor coherente
        """
        if userName.isspace() or userPassword.isspace() or userRol.isspace():
            raise ValueError("No se permiten espacios en blanco en los campos")

        conn = sql.connect(database)
        cursor = conn.cursor()

        # Leer imagen en formato binario para ingresarlo en la base de datos
        with open(userImg, 'rb') as file:
            datosImagen = file.read()
            cursor.execute('INSERT INTO ? (name, rol, password, img) VALUES (?, ?, ?, ?)', (table, userName, userPassword, userRol, datosImagen))
            conn.commit()

        conn.close()

    def ModificarUsuario(self, userNameToModify: str, database="DB_usuarios.db", table="users", **kwargs)->None:
        """Modificar valores de usuarios usando clave-valor

        Args:
            userNameToModify (str): Nombre del usuario a modificar
        KeyWordArgs:
            name (str): Nombre del nuevo usuario
            password(str): Contraseña del nuevo usuario
            rol (str): Rol del nuevo usuario
            img (Image): Archivo en formato de imagen (png, jpg).
        """

        args = tuple()
        format = ""

        for k, v in kwargs.items():
            format += f"{k} = ?, "
            if k == "img":
                with open(v, 'rb') as file:
                    datosImagen = file.read()
                    args += (datosImagen, )
                continue
            args += (v, )

        format = format[:-2]


        conn = sql.connect(database)
        cursor = conn.cursor()

        commandExecute = f"""
UPDATE {table}
SET {format}
WHERE name = '{userNameToModify}'
"""
        cursor.execute(commandExecute, args)

        conn.commit()
        conn.close()

if __name__ == "__main__":
    dbman = IODatabase()
    dbman.ModificarUsuario(userNameToModify="jp", password="123", img="img_user.jpg")

