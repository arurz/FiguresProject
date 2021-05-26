# FiguresProject
This is a project for working with figures. The application provides a graphical interface for work - Windows Forms. Customer can create figures such as Triangle, Circle, Square, Rectangle, Ellipse and Pentagon.
As a functional change, the app provides the ability to interact with figures:
	• Selecting a shape, deleting, moving selected figure, enlarging or rotating certain figure.
	• The ability to get the area and perimeter of the selected figure.
  • The ability to save the created figures and use them when you reopen the program.

Mouse and Keyboard Events:
	• If the user presses the left mouse button on a specific shape, that shape becomes selected.
	• If there are selected shapes, the user can click on the Delete button in the function section. When you click Delete All, all shapes are deleted.
	• If there is a selected shape, the user can enlarge the shape or start rotating it with the mouse wheel.
	• It is also possible to move the selected shape or find out its area and perimeter by pressing the corresponding buttons in the Functions section.
	• In the Shape Creation section, you can create shapes of your choice. Pressing the shape creation button will open the corresponding window for defining the shape parameters.
	• When you click on the Save button, all the shapes created on the scene will be saved to a file and can be used when you click on the Download button in the application's introductory dialog box.

Technical features of the program:
	• The coordinates and sizes of the shapes are saved as properties.
	• The principle of Inheritance is used for hierarchies of figure classes.
	• The program contains encapsulated variables and methods for drawing shapes.
	• Polymorphism is used to save shapes in the scene collection and to work with them.
	• Virtual methods are used in calculating area and perimeter, drawing shapes, and checking the content of a point in a figure.
	• The program uses the System.Drawing functionality to render shapes.
