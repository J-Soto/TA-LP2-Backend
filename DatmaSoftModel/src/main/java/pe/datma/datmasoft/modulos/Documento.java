/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.modulos;

/**
 *
 * @author maldo
 */
public class Documento extends Material {
    
    private byte[] docPDF;

    public byte[] getDocPDF() {
        return docPDF;
    }

    public void setDocPDF(byte[] docPDF) {
        this.docPDF = docPDF;
    }
    
}
