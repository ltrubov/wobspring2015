/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package net.response.clashgame;

import metadata.NetworkCode;
import net.response.GameResponse;

/**
 *
 * @author lev
 */
public class ResponseClashEndBattle extends GameResponse{
    
    
    public ResponseClashEndBattle(){
        response_id = NetworkCode.CLASH_END_BATTLE;
    }
    
    @Override
    public byte[] getBytes() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
}
