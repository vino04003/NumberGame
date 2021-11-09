import java.util.ArrayList;

import com.google.api.translate.Language;
import com.google.api.translate.Translator;

public class Translation {
    public static void main(String[] args) {                
        // Translate a single English String to French
        Translator translator = new Translator();
        System.out.println("Saying goodbye in French:");
        System.out.println(translator.translate("goodbye", Language.ENGLISH, Language.FRENCH));

        System.out.println();
    }
}