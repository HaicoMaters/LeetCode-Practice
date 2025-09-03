// Last updated: 03/09/2025, 12:28:13
public class ParkingSystem {

    int[] slots;

    public ParkingSystem(int big, int medium, int small) {
        slots = new int[3];
        slots[0] = big;
        slots[1] = medium;
        slots[2] = small;
    }
    
    public bool AddCar(int carType) {
        if(slots[carType-1] > 0)
        {
            slots[carType-1]--;
            return true;
        }
        return false;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */