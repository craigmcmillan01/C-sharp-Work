import java.util.*;
import javax.swing.JOptionPane;
public class main {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		JOptionPane.showMessageDialog(null, "text", "this is a window",JOptionPane.INFORMATION_MESSAGE);
		Car c1 = new Car("Peugeot", "206", "Grey");
		
		String output = c1.toString();
		c1.printDetails();
		
	}

}
