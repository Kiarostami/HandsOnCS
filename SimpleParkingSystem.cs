public class ParkingSystem {
    
    private int BigSpace, MediumSpace, SmallSpace;

    public ParkingSystem(int big, int medium, int small) {
        
        BigSpace = big;
        MediumSpace = medium;
        SmallSpace = small;
        
    }
    
    public bool AddCar(int carType) {
        
        if((carType == 1) && (BigSpace>0))
        {
            BigSpace --;
            return true;
        }
        
        else if((carType == 2) && (MediumSpace>0))
        {
            MediumSpace --;
            return true;
        }
        
        else if((carType == 3) && (SmallSpace>0))
        {
            SmallSpace --;
            return true;
        }
        else 
        {
            return false;
        }
        
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */
