public class BoosterPump : Pump
{
    //ATTRIBUTES
    private Xmtr _pumpPSI;

    //CONSTRUCTORS

    //GETS & SETS

    //METHODS
    public override void RunLogic()
    {
        if (_runCmd == true)
        {
            _running = true;
        }

        if (_runCmd == false)
        {
            _running = false;
        }

        
    }

}