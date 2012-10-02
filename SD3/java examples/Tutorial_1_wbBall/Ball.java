import javax.swing.JOptionPane;
public class Ball {
	//properties
	protected String colour;
	protected String Name; 
	//constructors
	public Ball(){}
	
	public Ball(String colour, String name){
		setColour(colour);
		setName(name);
	}
	
	//gets and sets
	public void setColour(String Colour){this.colour = Colour; }
	public String getColour() {return this.colour; }
	public void setName(String Name) {this.Name = Name;}
	public String getName() {return this.Name;}
	
}

