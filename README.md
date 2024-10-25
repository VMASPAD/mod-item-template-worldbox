# Como Empezar

Bienvenidos a al tutorial de como crear tu propio item para worldbox, la idea de este turorial es de que puedas descargar el ejemplo, y modificar tanto eliminar como agregar atributos, items, sprites, etc. Es un tutorial basico y limitado ya que la informacion que se recopilo para hacer este tutorial fue limitada, corta o no oficial por parte del creador, NO ME HAGO RESPONSABLE DEL MAL USO QUE LE DEN.

# ES RECOMENDABLE VER EL [VIDEO](https://youtu.be/SfKF1ufcSqg)

### Links

[Harmony](https://github.com/pardeike/Harmony/releases)

[DotWeen ](https://dotween.demigiant.com/download.php)

[Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json)

[Beebyte-Deobfuscator](https://github.com/OsOmE1/Beebyte-Deobfuscator)

[Mod Base](https://gamebanana.com/mods/546954)

### Que hacer?

Tienen que descargar el archivo zip  apretando en el boton de code arriba de todo (Es de color celeste), luego en *Download Zip*

Luego lo agregan en la carpeta mods descomprimida, tienen el [video](https://www.youtube.com/watch?v=Aq6i8k8zjGk) como hacerlo. De todas formas tienen un video de que trata de como inicializar el proyecto

* NO MODIFICAR `Traits.cs`
* NO MODIFICAR `TraitsGroups.cs `

### Dentro de los archivos aparecera lo que se puede modificar y lo que no

En cada archivo estara una palabra clave `woden,diamon,bots, etc` basicamente es el nombre clave que tiene la unidad cuando se crea, en cada archivo estara separado cuando debes copiar cada cosa y en donde declarar cada una, solo leer los comentarios y podras saber que cosas agregar.

En la estructura de archivos de las imagenes, solo cambia los sprites con el nombre clave o con el mismo que hayas creado, recuerda dejar al menos uno de cada uno para saber su estructura, las imagenes por lo general no llevan este id, si no que lo tiene la misma carpata:

`GameReources/Weapons`

Luego para tener un codigo mas legible para que lo puedas modificar como quieras, habra una lista de las variables que tienes que modificar para poder saber que es cada parte, basicamente que puedas darle su propio ID

### Datos:

### Items.cs

Este archivo define la clase [`Items`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html) dentro del espacio de nombres [`minecrafttools`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html). La clase [`Items`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html) tiene varios métodos estáticos:

* [`init()`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html): Inicializa varios objetos de tipo [`ItemAsset`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html) como [`ironsword`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html), [`IronChestPlate`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html), y [`IronHelmet`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html), configurando sus estadísticas y añadiéndolos al gestor de activos ([`AssetManager.items.list`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html)). También añade localizaciones y sprites para estos objetos.
* [`NoneAttackSomeoneAction`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html), [`NoneRegularAction`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html), [`NoneGetAttackedAction`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html), [`NoneDeathAction`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html): Métodos que parecen ser acciones predeterminadas que no realizan ninguna acción específica.
* [`addWeaponsSprite(string id, string material)`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html): Método para añadir sprites de armas.

### Traits.cs

Este archivo define la clase [`Traits`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html) dentro del espacio de nombres [`minecrafttools`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html). La clase [`Traits`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html) tiene varios métodos estáticos:

* [`init()`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html): Método vacío que parece ser generado por una herramienta llamada ModMaker.
* [`NoneAttackSomeoneAction`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html), [`NoneRegularAction`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html), [`NoneGetAttackedAction`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html), [`NoneDeathAction`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html): Métodos que no realizan ninguna acción específica, similares a los de la clase [`Items`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html).
* [`addTraitToLocalizedLibrary(string id, string description)`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html): Añade un rasgo a la biblioteca localizada, utilizando reflexión para acceder a campos privados de [`LocalizedTextManager`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html).

### Main.cs

Este archivo define la clase [`Main`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html) dentro del espacio de nombres [`minecrafttools`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html). La clase [`Main`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html) hereda de [`MonoBehaviour`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html) y tiene los siguientes miembros:

* [`instance`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html): Una instancia estática de [`Main`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html).
* [`harmony`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html): Una instancia estática de [`Harmony`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html).
* [`Awake()`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html): Método que se llama al inicializar el mod. Este método imprime mensajes de depuración y llama a los métodos [`init`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html) de las clases [`TraitGroup`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html), [`Traits`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html), y [`Items`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html) para inicializar los elementos y rasgos del mod.

### TraitsGroups.cs

No se proporciona un extracto de este archivo, pero basándonos en el nombre, es probable que defina la clase [`TraitGroup`](vscode-file://vscode-app/c:/Users/tomas/AppData/Local/Programs/Microsoft%20VS%20Code/resources/app/out/vs/code/electron-sandbox/workbench/workbench.esm.html) y contenga métodos y propiedades relacionados con la gestión de grupos de rasgos.

En resumen, estos archivos trabajan juntos para definir y inicializar elementos y rasgos personalizados en el mod, utilizando varias técnicas como la reflexión y la gestión de activos.
