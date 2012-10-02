import javax.swing.JOptionPane;

public class Car {
//instance variables
	private String make, model, colour;
	
	public Car() {} //does nothing but must be included
	
	//Constructor with parameters
	public Car(String make, String model, String colour)
	{
		setMake(make);
		setModel(model);
		setColour(colour);
	}
	
	//returns a string representation of this class
	public String toString()
	{
		String output;
		output = "Make:"+this.make+"\nModel:"+this.model+"\nColour:"+this.colour;
		
		return output;
	}
	//print details
	public void printDetails()
	{
		String output;
		output = toString();
		//display message
		JOptionPane.showMessageDialog(null, output, "Details of Car",
				JOptionPane.INFORMATION_MESSAGE);
	}
	
	//get and sets methods for make
	public String getMake(){return this.make;}
	public void setMake(String make){this.make = make;}
	
	//get and set methods for model
	public String getModel() { return this.model; }
	public void setModel(String Model){this.model = Model; }
	
	//get and set methods for colour
	public String getColour() { return this.colour; }
	public void setColour(String colour) { this.colour = colour; }
}//end class
