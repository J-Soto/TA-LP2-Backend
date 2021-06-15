package pe.datma.datmasoft.dao;


import java.util.ArrayList;
import pe.datma.datmasoft.modulos.Documento;
import pe.datma.datmasoft.modulos.Material;
import pe.datma.datmasoft.modulos.Video;

public interface MaterialDAO {
    int insertarMaterialVideo(Video video);
    int insertarMaterialDocumento(Documento documento);
    int modificarMaterialVideo(Video video);
    int modificarMaterialDocumento(Documento documento);
    ArrayList<Video> listarVideos();
    ArrayList<Documento> listarDocumentos();
    int eliminarMaterial(int idMaterial);
}
