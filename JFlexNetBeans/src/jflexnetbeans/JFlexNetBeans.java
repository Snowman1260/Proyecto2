/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jflexnetbeans;

import java.io.File;

/**
 *
 * @author stevi
 */
public class JFlexNetBeans {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        String rutaLexer = "C:/Users/stevi/Documents/NetBeansProjects/JFlexNetBeans/src/jflexnetbeans/Lexer.flex";
        generarJavaLexer(rutaLexer);
    }
    
    public static void generarJavaLexer(String rutaLexer){
        File archivo = new File(rutaLexer);
        jflex.Main.generate(archivo);
    }
    
}
