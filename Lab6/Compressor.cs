namespace Lab6;

public class Compressor
{
    // Унікальний ідентифікатор компресора
    private int id;
    
    // Потужність компресора в кіловатах (кВт)
    private double power;
    
    // Робочий об'єм компресора в кубічних метрах (м³)
    private double displacementVolume;
    
    // Максимальний тиск стиснення, який може виробляти компресор, в Паскалях (Па)
    private double maxCompressionPressure;
    
    // Робоча частота компресора в герцах (Гц)
    private double frequency;
    
    // Тип компресора (поршневий, відцентровий, винтовий тощо)
    private string type;
}